using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Coordinates
{
	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_zero;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NorthNeighbor_Public_get_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SouthNeighbor_Public_get_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WestNeighbor_Public_get_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EastNeighbor_Public_get_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NorthWestNeighbor_Public_get_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NorthEastNeighbor_Public_get_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SouthWestNeighbor_Public_get_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SouthEastNeighbor_Public_get_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlusX_Public_Coordinates_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlusY_Public_Coordinates_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNeighbors_Public_Void_ICollection_1_Coordinates_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNeighborsWithinRadius_Public_Void_Int32_Boolean_ICollection_1_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsVector_Public_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Coordinates_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistanceSq_Public_Static_Single_Coordinates_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Coordinates_Coordinates_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Coordinates_Coordinates_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinates_Coordinates_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinates_Coordinates_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Coordinates_Coordinates_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Coordinates_Coordinates_Vector2_0;

	[FieldOffset(0)]
	public int x;

	[FieldOffset(4)]
	public int y;

	public unsafe static Coordinates zero
	{
		get
		{
			Unsafe.SkipInit(out Coordinates result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zero, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zero, (void*)(&coordinates));
		}
	}

	public unsafe Coordinates NorthNeighbor
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 260908, RefRangeEnd = 260919, XrefRangeStart = 260908, XrefRangeEnd = 260908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NorthNeighbor_Public_get_Coordinates_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Coordinates SouthNeighbor
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 260919, RefRangeEnd = 260930, XrefRangeStart = 260919, XrefRangeEnd = 260919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SouthNeighbor_Public_get_Coordinates_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Coordinates WestNeighbor
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 260930, RefRangeEnd = 260942, XrefRangeStart = 260930, XrefRangeEnd = 260930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WestNeighbor_Public_get_Coordinates_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Coordinates EastNeighbor
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 260942, RefRangeEnd = 260953, XrefRangeStart = 260942, XrefRangeEnd = 260942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EastNeighbor_Public_get_Coordinates_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Coordinates NorthWestNeighbor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260953, RefRangeEnd = 260954, XrefRangeStart = 260953, XrefRangeEnd = 260953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NorthWestNeighbor_Public_get_Coordinates_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Coordinates NorthEastNeighbor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260954, RefRangeEnd = 260955, XrefRangeStart = 260954, XrefRangeEnd = 260954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NorthEastNeighbor_Public_get_Coordinates_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Coordinates SouthWestNeighbor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260955, RefRangeEnd = 260956, XrefRangeStart = 260955, XrefRangeEnd = 260955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SouthWestNeighbor_Public_get_Coordinates_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Coordinates SouthEastNeighbor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260956, RefRangeEnd = 260957, XrefRangeStart = 260956, XrefRangeEnd = 260956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SouthEastNeighbor_Public_get_Coordinates_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float sqrMagnitude
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260959, RefRangeEnd = 260960, XrefRangeStart = 260959, XrefRangeEnd = 260959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static Coordinates()
	{
		Il2CppClassPointerStore<Coordinates>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "Coordinates");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coordinates>.NativeClassPtr);
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, "y");
		NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, "zero");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683312);
		NativeMethodInfoPtr__ctor_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683313);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683314);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683315);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683316);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683317);
		NativeMethodInfoPtr_get_NorthNeighbor_Public_get_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683318);
		NativeMethodInfoPtr_get_SouthNeighbor_Public_get_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683319);
		NativeMethodInfoPtr_get_WestNeighbor_Public_get_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683320);
		NativeMethodInfoPtr_get_EastNeighbor_Public_get_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683321);
		NativeMethodInfoPtr_get_NorthWestNeighbor_Public_get_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683322);
		NativeMethodInfoPtr_get_NorthEastNeighbor_Public_get_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683323);
		NativeMethodInfoPtr_get_SouthWestNeighbor_Public_get_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683324);
		NativeMethodInfoPtr_get_SouthEastNeighbor_Public_get_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683325);
		NativeMethodInfoPtr_PlusX_Public_Coordinates_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683326);
		NativeMethodInfoPtr_PlusY_Public_Coordinates_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683327);
		NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683328);
		NativeMethodInfoPtr_GetAllNeighbors_Public_Void_ICollection_1_Coordinates_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683329);
		NativeMethodInfoPtr_GetAllNeighborsWithinRadius_Public_Void_Int32_Boolean_ICollection_1_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683330);
		NativeMethodInfoPtr_AsVector_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683331);
		NativeMethodInfoPtr_Distance_Public_Static_Single_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683332);
		NativeMethodInfoPtr_DistanceSq_Public_Static_Single_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683333);
		NativeMethodInfoPtr_op_Addition_Public_Static_Coordinates_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683334);
		NativeMethodInfoPtr_op_Addition_Public_Static_Coordinates_Coordinates_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683335);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinates_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683336);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinates_Coordinates_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683337);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Coordinates_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683338);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Coordinates_Coordinates_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, 100683339);
	}

	[CallerCount(159)]
	[CachedScanResults(RefRangeStart = 25884, RefRangeEnd = 26043, XrefRangeStart = 25884, XrefRangeEnd = 26043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260861, RefRangeEnd = 260862, XrefRangeStart = 260861, XrefRangeEnd = 260861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates(Vector2 vector2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 260862, RefRangeEnd = 260886, XrefRangeStart = 260862, XrefRangeEnd = 260862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(Coordinates other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Coordinates_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260886, XrefRangeEnd = 260891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 260891, RefRangeEnd = 260894, XrefRangeStart = 260891, XrefRangeEnd = 260891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 260902, RefRangeEnd = 260908, XrefRangeStart = 260894, XrefRangeEnd = 260902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260957, RefRangeEnd = 260958, XrefRangeStart = 260957, XrefRangeEnd = 260957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates PlusX(int delta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlusX_Public_Coordinates_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260958, RefRangeEnd = 260959, XrefRangeStart = 260958, XrefRangeEnd = 260958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates PlusY(int delta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlusY_Public_Coordinates_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 260969, RefRangeEnd = 260985, XrefRangeStart = 260960, XrefRangeEnd = 260969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAllNeighbors(ICollection<Coordinates> result, bool includeSelf = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeSelf;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllNeighbors_Public_Void_ICollection_1_Coordinates_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 260992, RefRangeEnd = 261012, XrefRangeStart = 260985, XrefRangeEnd = 260992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAllNeighborsWithinRadius(int radius, bool includeSelf, ICollection<Coordinates> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&radius);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeSelf;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllNeighborsWithinRadius_Public_Void_Int32_Boolean_ICollection_1_Coordinates_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Vector2 AsVector()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsVector_Public_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261012, XrefRangeEnd = 261015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Distance(Coordinates one, Coordinates two)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&one);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &two;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Distance_Public_Static_Single_Coordinates_Coordinates_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float DistanceSq(Coordinates one, Coordinates two)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&one);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &two;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistanceSq_Public_Static_Single_Coordinates_Coordinates_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 261015, RefRangeEnd = 261029, XrefRangeStart = 261015, XrefRangeEnd = 261015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Coordinates operator +(Coordinates a, Coordinates b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_Coordinates_Coordinates_Coordinates_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 261029, RefRangeEnd = 261036, XrefRangeStart = 261029, XrefRangeEnd = 261029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Coordinates operator +(Coordinates a, Vector2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_Coordinates_Coordinates_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 261036, RefRangeEnd = 261044, XrefRangeStart = 261036, XrefRangeEnd = 261036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Coordinates operator -(Coordinates a, Coordinates b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinates_Coordinates_Coordinates_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 261044, RefRangeEnd = 261045, XrefRangeStart = 261044, XrefRangeEnd = 261044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Coordinates operator -(Coordinates a, Vector2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinates_Coordinates_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Coordinates operator *(Coordinates a, Coordinates b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Coordinates_Coordinates_Coordinates_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Coordinates operator *(Coordinates a, Vector2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Coordinates_Coordinates_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Coordinates>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

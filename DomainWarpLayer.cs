using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DomainWarpLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_domainWarpVectors;

	private static readonly System.IntPtr NativeFieldInfoPtr_octaves;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_List_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_domainWarp_Private_Void_byref_Single_byref_Single_Vector2_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeInputCoordinates_Public_Virtual_Final_New_Void_byref_Single_byref_Single_0;

	public unsafe List<Vector2> domainWarpVectors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_domainWarpVectors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_domainWarpVectors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int octaves
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_octaves);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_octaves)) = num;
		}
	}

	static DomainWarpLayer()
	{
		Il2CppClassPointerStore<DomainWarpLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DomainWarpLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DomainWarpLayer>.NativeClassPtr);
		NativeFieldInfoPtr_domainWarpVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomainWarpLayer>.NativeClassPtr, "domainWarpVectors");
		NativeFieldInfoPtr_octaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomainWarpLayer>.NativeClassPtr, "octaves");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainWarpLayer>.NativeClassPtr, 100683866);
		NativeMethodInfoPtr_domainWarp_Private_Void_byref_Single_byref_Single_Vector2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainWarpLayer>.NativeClassPtr, 100683867);
		NativeMethodInfoPtr_ComputeInputCoordinates_Public_Virtual_Final_New_Void_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainWarpLayer>.NativeClassPtr, 100683868);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271644, XrefRangeEnd = 271646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DomainWarpLayer(int octaves, List<Vector2> domainWarpVectors)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DomainWarpLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&octaves);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)domainWarpVectors);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271646, XrefRangeEnd = 271648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void domainWarp(ref float xCoord, ref float yCoord, Vector2 displacement1, Vector2 displacement2, int octaves)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref xCoord);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref yCoord);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &displacement1;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &displacement2;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &octaves;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_domainWarp_Private_Void_byref_Single_byref_Single_Vector2_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271648, XrefRangeEnd = 271657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ComputeInputCoordinates(ref float xCoord, ref float yCoord)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref xCoord);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref yCoord);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeInputCoordinates_Public_Virtual_Final_New_Void_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DomainWarpLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

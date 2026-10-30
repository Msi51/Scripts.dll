using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public static class SortUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_DistanceBasedInsert_Public_Static_Void_Entity_List_1_Entity_Vector3_0;

	static SortUtil()
	{
		Il2CppClassPointerStore<SortUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SortUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortUtil>.NativeClassPtr);
		NativeMethodInfoPtr_DistanceBasedInsert_Public_Static_Void_Entity_List_1_Entity_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortUtil>.NativeClassPtr, 100667943);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 85699, RefRangeEnd = 85701, XrefRangeStart = 85688, XrefRangeEnd = 85699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DistanceBasedInsert(Entity entity, List<Entity> list, Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistanceBasedInsert_Public_Static_Void_Entity_List_1_Entity_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SortUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

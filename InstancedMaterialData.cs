using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class InstancedMaterialData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_meshMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowCastingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_layer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<Mesh, List<Matrix4x4>> meshMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Mesh, List<Matrix4x4>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe ShadowCastingMode shadowCastingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowCastingMode);
			return *(ShadowCastingMode*)num;
		}
		set
		{
			*(ShadowCastingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowCastingMode)) = shadowCastingMode;
		}
	}

	public unsafe int layer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layer)) = num;
		}
	}

	static InstancedMaterialData()
	{
		Il2CppClassPointerStore<InstancedMaterialData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InstancedMaterialData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstancedMaterialData>.NativeClassPtr);
		NativeFieldInfoPtr_meshMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancedMaterialData>.NativeClassPtr, "meshMap");
		NativeFieldInfoPtr_shadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancedMaterialData>.NativeClassPtr, "shadowCastingMode");
		NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancedMaterialData>.NativeClassPtr, "layer");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancedMaterialData>.NativeClassPtr, 100669793);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 106876, RefRangeEnd = 106877, XrefRangeStart = 106867, XrefRangeEnd = 106876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InstancedMaterialData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstancedMaterialData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InstancedMaterialData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

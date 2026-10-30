using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

public class MaterialUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_surface;

	private static readonly System.IntPtr NativeFieldInfoPtr_cutoff;

	private static readonly System.IntPtr NativeFieldInfoPtr_srcBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_dstBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_zWrite;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableCutout_Public_Static_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableTransparency_Public_Static_Void_Material_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableTransparency_Public_Static_Void_Material_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int surface
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_surface, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_surface, (void*)(&num));
		}
	}

	public unsafe static int cutoff
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cutoff, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cutoff, (void*)(&num));
		}
	}

	public unsafe static int srcBlend
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_srcBlend, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_srcBlend, (void*)(&num));
		}
	}

	public unsafe static int dstBlend
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dstBlend, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dstBlend, (void*)(&num));
		}
	}

	public unsafe static int zWrite
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zWrite, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zWrite, (void*)(&num));
		}
	}

	static MaterialUtil()
	{
		Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MaterialUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr);
		NativeFieldInfoPtr_surface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr, "surface");
		NativeFieldInfoPtr_cutoff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr, "cutoff");
		NativeFieldInfoPtr_srcBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr, "srcBlend");
		NativeFieldInfoPtr_dstBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr, "dstBlend");
		NativeFieldInfoPtr_zWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr, "zWrite");
		NativeMethodInfoPtr_EnableCutout_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr, 100667773);
		NativeMethodInfoPtr_EnableTransparency_Public_Static_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr, 100667774);
		NativeMethodInfoPtr_DisableTransparency_Public_Static_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr, 100667775);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr, 100667776);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 82378, RefRangeEnd = 82379, XrefRangeStart = 82355, XrefRangeEnd = 82378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableCutout(Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableCutout_Public_Static_Void_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 82424, RefRangeEnd = 82426, XrefRangeStart = 82379, XrefRangeEnd = 82424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableTransparency(Material material, bool emission = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &emission;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableTransparency_Public_Static_Void_Material_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82426, XrefRangeEnd = 82456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableTransparency(Material material, bool emission = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &emission;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableTransparency_Public_Static_Void_Material_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaterialUtil()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialUtil>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MaterialUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

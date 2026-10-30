using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;
using UnityEngine;

public static class ColorUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_orange;

	private static readonly System.IntPtr NativeFieldInfoPtr_youColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_hungerColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirstColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitpointsColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseRemovalColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_energyColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_staminaColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_rustColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_softGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_softRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_filthYellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_sanitationBlue;

	private static readonly System.IntPtr NativeFieldInfoPtr_severeRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_criticalRed;

	private static readonly System.IntPtr NativeMethodInfoPtr_Desaturate_Public_Static_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsFloat3_Public_Static_float3_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsColor_Public_Static_Color_float3_0;

	public unsafe static Color orange
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_orange, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_orange, (void*)(&color));
		}
	}

	public unsafe static Color youColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_youColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_youColor, (void*)(&color));
		}
	}

	public unsafe static Color npcColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_npcColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_npcColor, (void*)(&color));
		}
	}

	public unsafe static Color hungerColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hungerColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hungerColor, (void*)(&color));
		}
	}

	public unsafe static Color thirstColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_thirstColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_thirstColor, (void*)(&color));
		}
	}

	public unsafe static Color hitpointsColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hitpointsColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hitpointsColor, (void*)(&color));
		}
	}

	public unsafe static Color diseaseColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_diseaseColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_diseaseColor, (void*)(&color));
		}
	}

	public unsafe static Color diseaseRemovalColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_diseaseRemovalColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_diseaseRemovalColor, (void*)(&color));
		}
	}

	public unsafe static Color energyColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_energyColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_energyColor, (void*)(&color));
		}
	}

	public unsafe static Color staminaColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_staminaColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_staminaColor, (void*)(&color));
		}
	}

	public unsafe static Color rustColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rustColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rustColor, (void*)(&color));
		}
	}

	public unsafe static Color softGreen
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_softGreen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_softGreen, (void*)(&color));
		}
	}

	public unsafe static Color softRed
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_softRed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_softRed, (void*)(&color));
		}
	}

	public unsafe static Color injuryGreen
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_injuryGreen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_injuryGreen, (void*)(&color));
		}
	}

	public unsafe static Color injuryRed
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_injuryRed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_injuryRed, (void*)(&color));
		}
	}

	public unsafe static Color filthYellow
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_filthYellow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_filthYellow, (void*)(&color));
		}
	}

	public unsafe static Color sanitationBlue
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sanitationBlue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sanitationBlue, (void*)(&color));
		}
	}

	public unsafe static Color severeRed
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_severeRed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_severeRed, (void*)(&color));
		}
	}

	public unsafe static Color criticalRed
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_criticalRed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_criticalRed, (void*)(&color));
		}
	}

	static ColorUtil()
	{
		Il2CppClassPointerStore<ColorUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ColorUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr);
		NativeFieldInfoPtr_orange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "orange");
		NativeFieldInfoPtr_youColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "youColor");
		NativeFieldInfoPtr_npcColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "npcColor");
		NativeFieldInfoPtr_hungerColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "hungerColor");
		NativeFieldInfoPtr_thirstColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "thirstColor");
		NativeFieldInfoPtr_hitpointsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "hitpointsColor");
		NativeFieldInfoPtr_diseaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "diseaseColor");
		NativeFieldInfoPtr_diseaseRemovalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "diseaseRemovalColor");
		NativeFieldInfoPtr_energyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "energyColor");
		NativeFieldInfoPtr_staminaColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "staminaColor");
		NativeFieldInfoPtr_rustColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "rustColor");
		NativeFieldInfoPtr_softGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "softGreen");
		NativeFieldInfoPtr_softRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "softRed");
		NativeFieldInfoPtr_injuryGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "injuryGreen");
		NativeFieldInfoPtr_injuryRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "injuryRed");
		NativeFieldInfoPtr_filthYellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "filthYellow");
		NativeFieldInfoPtr_sanitationBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "sanitationBlue");
		NativeFieldInfoPtr_severeRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "severeRed");
		NativeFieldInfoPtr_criticalRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, "criticalRed");
		NativeMethodInfoPtr_Desaturate_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100667656);
		NativeMethodInfoPtr_AsFloat3_Public_Static_float3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100667657);
		NativeMethodInfoPtr_AsColor_Public_Static_Color_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100667658);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 80222, RefRangeEnd = 80224, XrefRangeStart = 80220, XrefRangeEnd = 80222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color Desaturate(Color color, float desaturationAmount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &desaturationAmount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Desaturate_Public_Static_Color_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 80224, RefRangeEnd = 80255, XrefRangeStart = 80224, XrefRangeEnd = 80224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float3 AsFloat3(this Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsFloat3_Public_Static_float3_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 80255, RefRangeEnd = 80256, XrefRangeStart = 80255, XrefRangeEnd = 80255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color AsColor(this float3 f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsColor_Public_Static_Color_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ColorUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

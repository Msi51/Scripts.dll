using System;
using System.Runtime.CompilerServices;
using FullSerializer.Internal.Converters;
using FullSerializer.Internal.DirectConverters;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace FullSerializer;

public class fsConverterRegistrar : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Register_AnimationCurve_DirectConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Register_Bounds_DirectConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Register_Gradient_DirectConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Register_GUIStyleState_DirectConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Register_GUIStyle_DirectConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Register_Keyframe_DirectConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Register_LayerMask_DirectConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Register_RectOffset_DirectConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Register_Rect_DirectConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Register_UnityEvent_Converter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Converters;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static AnimationCurve_DirectConverter Register_AnimationCurve_DirectConverter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Register_AnimationCurve_DirectConverter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve_DirectConverter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Register_AnimationCurve_DirectConverter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve_DirectConverter));
		}
	}

	public unsafe static Bounds_DirectConverter Register_Bounds_DirectConverter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Register_Bounds_DirectConverter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Bounds_DirectConverter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Register_Bounds_DirectConverter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bounds_DirectConverter));
		}
	}

	public unsafe static Gradient_DirectConverter Register_Gradient_DirectConverter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Register_Gradient_DirectConverter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient_DirectConverter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Register_Gradient_DirectConverter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gradient_DirectConverter));
		}
	}

	public unsafe static GUIStyleState_DirectConverter Register_GUIStyleState_DirectConverter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Register_GUIStyleState_DirectConverter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyleState_DirectConverter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Register_GUIStyleState_DirectConverter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUIStyleState_DirectConverter));
		}
	}

	public unsafe static GUIStyle_DirectConverter Register_GUIStyle_DirectConverter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Register_GUIStyle_DirectConverter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle_DirectConverter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Register_GUIStyle_DirectConverter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUIStyle_DirectConverter));
		}
	}

	public unsafe static Keyframe_DirectConverter Register_Keyframe_DirectConverter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Register_Keyframe_DirectConverter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Keyframe_DirectConverter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Register_Keyframe_DirectConverter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyframe_DirectConverter));
		}
	}

	public unsafe static LayerMask_DirectConverter Register_LayerMask_DirectConverter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Register_LayerMask_DirectConverter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayerMask_DirectConverter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Register_LayerMask_DirectConverter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layerMask_DirectConverter));
		}
	}

	public unsafe static RectOffset_DirectConverter Register_RectOffset_DirectConverter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Register_RectOffset_DirectConverter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectOffset_DirectConverter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Register_RectOffset_DirectConverter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectOffset_DirectConverter));
		}
	}

	public unsafe static Rect_DirectConverter Register_Rect_DirectConverter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Register_Rect_DirectConverter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rect_DirectConverter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Register_Rect_DirectConverter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect_DirectConverter));
		}
	}

	public unsafe static UnityEvent_Converter Register_UnityEvent_Converter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Register_UnityEvent_Converter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent_Converter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Register_UnityEvent_Converter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent_Converter));
		}
	}

	public unsafe static List<Il2CppSystem.Type> Converters
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Converters, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Converters, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static fsConverterRegistrar()
	{
		Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsConverterRegistrar");
		NativeFieldInfoPtr_Register_AnimationCurve_DirectConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Register_AnimationCurve_DirectConverter");
		NativeFieldInfoPtr_Register_Bounds_DirectConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Register_Bounds_DirectConverter");
		NativeFieldInfoPtr_Register_Gradient_DirectConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Register_Gradient_DirectConverter");
		NativeFieldInfoPtr_Register_GUIStyleState_DirectConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Register_GUIStyleState_DirectConverter");
		NativeFieldInfoPtr_Register_GUIStyle_DirectConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Register_GUIStyle_DirectConverter");
		NativeFieldInfoPtr_Register_Keyframe_DirectConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Register_Keyframe_DirectConverter");
		NativeFieldInfoPtr_Register_LayerMask_DirectConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Register_LayerMask_DirectConverter");
		NativeFieldInfoPtr_Register_RectOffset_DirectConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Register_RectOffset_DirectConverter");
		NativeFieldInfoPtr_Register_Rect_DirectConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Register_Rect_DirectConverter");
		NativeFieldInfoPtr_Register_UnityEvent_Converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Register_UnityEvent_Converter");
		NativeFieldInfoPtr_Converters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, "Converters");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr, 100686558);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsConverterRegistrar()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsConverterRegistrar>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsConverterRegistrar(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

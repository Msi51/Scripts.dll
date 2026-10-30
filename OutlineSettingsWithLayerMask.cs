using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

[Serializable]
public class OutlineSettingsWithLayerMask : OutlineSettingsInstance
{
	private static readonly IntPtr NativeFieldInfoPtr__filterMode;

	private static readonly IntPtr NativeFieldInfoPtr__layerMask;

	private static readonly IntPtr NativeFieldInfoPtr__renderingLayerMask;

	private static readonly IntPtr NativeMethodInfoPtr_get_OutlineLayerMask_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_OutlineRenderingLayerMask_Public_get_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe OutlineFilterMode _filterMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__filterMode);
			return *(OutlineFilterMode*)num;
		}
		set
		{
			*(OutlineFilterMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__filterMode)) = outlineFilterMode;
		}
	}

	public unsafe LayerMask _layerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layerMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layerMask)) = layerMask;
		}
	}

	public unsafe uint _renderingLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderingLayerMask);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderingLayerMask)) = num;
		}
	}

	public unsafe int OutlineLayerMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OutlineLayerMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe uint OutlineRenderingLayerMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OutlineRenderingLayerMask_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static OutlineSettingsWithLayerMask()
	{
		Il2CppClassPointerStore<OutlineSettingsWithLayerMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "OutlineSettingsWithLayerMask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutlineSettingsWithLayerMask>.NativeClassPtr);
		NativeFieldInfoPtr__filterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineSettingsWithLayerMask>.NativeClassPtr, "_filterMode");
		NativeFieldInfoPtr__layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineSettingsWithLayerMask>.NativeClassPtr, "_layerMask");
		NativeFieldInfoPtr__renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineSettingsWithLayerMask>.NativeClassPtr, "_renderingLayerMask");
		NativeMethodInfoPtr_get_OutlineLayerMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineSettingsWithLayerMask>.NativeClassPtr, 100664358);
		NativeMethodInfoPtr_get_OutlineRenderingLayerMask_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineSettingsWithLayerMask>.NativeClassPtr, 100664359);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineSettingsWithLayerMask>.NativeClassPtr, 100664360);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29382, XrefRangeEnd = 29383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutlineSettingsWithLayerMask()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutlineSettingsWithLayerMask>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OutlineSettingsWithLayerMask(IntPtr pointer)
		: base(pointer)
	{
	}
}

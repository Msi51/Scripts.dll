using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Rendering;

public sealed class LogHistogram : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rangeMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_rangeMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Bins;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ThreadX;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ThreadY;

	private static readonly System.IntPtr NativeFieldInfoPtr__data_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_data_Public_get_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_data_Private_set_Void_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate_Public_Void_CommandBuffer_ComputeShader_RenderTargetIdentifier_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Public_Vector4_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int rangeMin
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rangeMin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rangeMin, (void*)(&num));
		}
	}

	public unsafe static int rangeMax
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rangeMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rangeMax, (void*)(&num));
		}
	}

	public unsafe static int k_Bins
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Bins, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Bins, (void*)(&num));
		}
	}

	public unsafe int m_ThreadX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ThreadX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ThreadX)) = num;
		}
	}

	public unsafe int m_ThreadY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ThreadY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ThreadY)) = num;
		}
	}

	public unsafe ComputeBuffer _data_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__data_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__data_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)computeBuffer));
		}
	}

	public unsafe ComputeBuffer data
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_data_Public_get_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28739, XrefRangeEnd = 28740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_data_Private_set_Void_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static LogHistogram()
	{
		Il2CppClassPointerStore<LogHistogram>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "LogHistogram");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr);
		NativeFieldInfoPtr_rangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, "rangeMin");
		NativeFieldInfoPtr_rangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, "rangeMax");
		NativeFieldInfoPtr_k_Bins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, "k_Bins");
		NativeFieldInfoPtr_m_ThreadX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, "m_ThreadX");
		NativeFieldInfoPtr_m_ThreadY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, "m_ThreadY");
		NativeFieldInfoPtr__data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, "<data>k__BackingField");
		NativeMethodInfoPtr_get_data_Public_get_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100664270);
		NativeMethodInfoPtr_set_data_Private_set_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100664271);
		NativeMethodInfoPtr_Generate_Public_Void_CommandBuffer_ComputeShader_RenderTargetIdentifier_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100664272);
		NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Public_Vector4_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100664273);
		NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100664274);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100664275);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28782, RefRangeEnd = 28783, XrefRangeStart = 28740, XrefRangeEnd = 28782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Generate(CommandBuffer cmd, ComputeShader histogramShader, RenderTargetIdentifier source, RenderTextureDescriptor renderTextureDescriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)histogramShader);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderTextureDescriptor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Generate_Public_Void_CommandBuffer_ComputeShader_RenderTargetIdentifier_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Vector4 GetHistogramScaleOffsetRes(RenderTextureDescriptor renderTextureDescriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renderTextureDescriptor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Public_Vector4_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28783, XrefRangeEnd = 28785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogHistogram()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LogHistogram(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

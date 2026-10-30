using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class SurfaceView : BaseView
{
	private static readonly IntPtr NativeFieldInfoPtr_baseSurfaceType;

	private static readonly IntPtr NativeFieldInfoPtr_customSurfaceType;

	private static readonly IntPtr NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_SurfaceTypeAtPosition_Public_Virtual_Final_New_SurfaceType_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCustomSurfaceType_Public_Virtual_Final_New_Void_SurfaceType_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearCustomSurfaceType_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SerializableEnumField<SurfaceType> baseSurfaceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseSurfaceType);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableEnumField<SurfaceType>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseSurfaceType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableEnumField));
		}
	}

	public unsafe SurfaceType customSurfaceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customSurfaceType);
			return *(SurfaceType*)num;
		}
		set
		{
			*(SurfaceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customSurfaceType)) = surfaceType;
		}
	}

	static SurfaceView()
	{
		Il2CppClassPointerStore<SurfaceView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SurfaceView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceView>.NativeClassPtr);
		NativeFieldInfoPtr_baseSurfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceView>.NativeClassPtr, "baseSurfaceType");
		NativeFieldInfoPtr_customSurfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceView>.NativeClassPtr, "customSurfaceType");
		NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceView>.NativeClassPtr, 100682961);
		NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceView>.NativeClassPtr, 100682962);
		NativeMethodInfoPtr_SurfaceTypeAtPosition_Public_Virtual_Final_New_SurfaceType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceView>.NativeClassPtr, 100682963);
		NativeMethodInfoPtr_SetCustomSurfaceType_Public_Virtual_Final_New_Void_SurfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceView>.NativeClassPtr, 100682964);
		NativeMethodInfoPtr_ClearCustomSurfaceType_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceView>.NativeClassPtr, 100682965);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceView>.NativeClassPtr, 100682966);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257151, XrefRangeEnd = 257153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetComponentName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257153, XrefRangeEnd = 257158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeSerializableFields(SerializationContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257158, XrefRangeEnd = 257159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual SurfaceType SurfaceTypeAtPosition(Vector3 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&worldPosition);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SurfaceTypeAtPosition_Public_Virtual_Final_New_SurfaceType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurfaceType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 257159, RefRangeEnd = 257160, XrefRangeStart = 257159, XrefRangeEnd = 257159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetCustomSurfaceType(SurfaceType surfaceType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&surfaceType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomSurfaceType_Public_Virtual_Final_New_Void_SurfaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void ClearCustomSurfaceType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCustomSurfaceType_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SurfaceView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceView>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SurfaceView(IntPtr pointer)
		: base(pointer)
	{
	}
}

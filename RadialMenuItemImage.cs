using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.UI;

public class RadialMenuItemImage : Image
{
	private static readonly IntPtr NativeFieldInfoPtr_buffer;

	private static readonly IntPtr NativeFieldInfoPtr_targetAngle;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_RadialMenuPlacement_0;

	private static readonly IntPtr NativeMethodInfoPtr_updateState_Private_Void_RadialMenuPlacement_0;

	private static readonly IntPtr NativeMethodInfoPtr_AngleWithin_Public_Boolean_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float buffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffer)) = num;
		}
	}

	public unsafe float targetAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetAngle)) = num;
		}
	}

	static RadialMenuItemImage()
	{
		Il2CppClassPointerStore<RadialMenuItemImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RadialMenuItemImage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadialMenuItemImage>.NativeClassPtr);
		NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialMenuItemImage>.NativeClassPtr, "buffer");
		NativeFieldInfoPtr_targetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialMenuItemImage>.NativeClassPtr, "targetAngle");
		NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialMenuItemImage>.NativeClassPtr, 100667518);
		NativeMethodInfoPtr_Render_Public_Void_RadialMenuPlacement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialMenuItemImage>.NativeClassPtr, 100667519);
		NativeMethodInfoPtr_updateState_Private_Void_RadialMenuPlacement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialMenuItemImage>.NativeClassPtr, 100667520);
		NativeMethodInfoPtr_AngleWithin_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialMenuItemImage>.NativeClassPtr, 100667521);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialMenuItemImage>.NativeClassPtr, 100667522);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79241, XrefRangeEnd = 79244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 79245, RefRangeEnd = 79246, XrefRangeStart = 79244, XrefRangeEnd = 79245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Render(RadialMenuPlacement placement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&placement);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Public_Void_RadialMenuPlacement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 79259, RefRangeEnd = 79260, XrefRangeStart = 79246, XrefRangeEnd = 79259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateState(RadialMenuPlacement placement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&placement);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateState_Private_Void_RadialMenuPlacement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 79262, RefRangeEnd = 79263, XrefRangeStart = 79260, XrefRangeEnd = 79262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AngleWithin(float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&angle);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AngleWithin_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79263, XrefRangeEnd = 79267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RadialMenuItemImage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadialMenuItemImage>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RadialMenuItemImage(IntPtr pointer)
		: base(pointer)
	{
	}
}

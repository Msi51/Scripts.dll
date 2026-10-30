using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.command.impl;

public class ShowTanningFrameUICommand : Command
{
	private static readonly IntPtr NativeFieldInfoPtr__signalParams_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__uiManager_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_signalParams_Public_get_ShowTanningFrameUISignalParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_signalParams_Public_set_Void_ShowTanningFrameUISignalParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_uiManager_Public_get_IUIManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_uiManager_Public_set_Void_IUIManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_showMainInventory_Private_MainInventoryUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ShowTanningFrameUISignalParams _signalParams_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__signalParams_k__BackingField);
			return new ShowTanningFrameUISignalParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTanningFrameUISignalParams>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__signalParams_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showTanningFrameUISignalParams)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShowTanningFrameUISignalParams>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe IUIManager _uiManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uiManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IUIManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uiManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iUIManager));
		}
	}

	public unsafe ShowTanningFrameUISignalParams signalParams
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_signalParams_Public_get_ShowTanningFrameUISignalParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ShowTanningFrameUISignalParams(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_signalParams_Public_set_Void_ShowTanningFrameUISignalParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IUIManager uiManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uiManager_Public_get_IUIManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IUIManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_uiManager_Public_set_Void_IUIManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ShowTanningFrameUICommand()
	{
		Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowTanningFrameUICommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr);
		NativeFieldInfoPtr__signalParams_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr, "<signalParams>k__BackingField");
		NativeFieldInfoPtr__uiManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr, "<uiManager>k__BackingField");
		NativeMethodInfoPtr_get_signalParams_Public_get_ShowTanningFrameUISignalParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr, 100669114);
		NativeMethodInfoPtr_set_signalParams_Public_set_Void_ShowTanningFrameUISignalParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr, 100669115);
		NativeMethodInfoPtr_get_uiManager_Public_get_IUIManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr, 100669116);
		NativeMethodInfoPtr_set_uiManager_Public_set_Void_IUIManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr, 100669117);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr, 100669118);
		NativeMethodInfoPtr_showMainInventory_Private_MainInventoryUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr, 100669119);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr, 100669120);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99717, XrefRangeEnd = 99740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99740, XrefRangeEnd = 99749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MainInventoryUI showMainInventory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showMainInventory_Private_MainInventoryUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MainInventoryUI>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowTanningFrameUICommand()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTanningFrameUICommand>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowTanningFrameUICommand(IntPtr pointer)
		: base(pointer)
	{
	}
}

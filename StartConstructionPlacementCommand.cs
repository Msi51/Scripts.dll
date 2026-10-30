using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.command.impl;

public class StartConstructionPlacementCommand : Command
{
	private static readonly IntPtr NativeFieldInfoPtr__signalParams_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__placeableManager_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_signalParams_Public_get_StartConstructionPlacementSignalParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_signalParams_Public_set_Void_StartConstructionPlacementSignalParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_placeableManager_Public_get_IPlaceableManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_placeableManager_Public_set_Void_IPlaceableManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe StartConstructionPlacementSignalParams _signalParams_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__signalParams_k__BackingField);
			return new StartConstructionPlacementSignalParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartConstructionPlacementSignalParams>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__signalParams_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startConstructionPlacementSignalParams)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StartConstructionPlacementSignalParams>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe IPlaceableManager _placeableManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__placeableManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IPlaceableManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__placeableManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placeableManager));
		}
	}

	public unsafe StartConstructionPlacementSignalParams signalParams
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_signalParams_Public_get_StartConstructionPlacementSignalParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new StartConstructionPlacementSignalParams(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_signalParams_Public_set_Void_StartConstructionPlacementSignalParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IPlaceableManager placeableManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32262, RefRangeEnd = 32263, XrefRangeStart = 32262, XrefRangeEnd = 32263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_placeableManager_Public_get_IPlaceableManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IPlaceableManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_placeableManager_Public_set_Void_IPlaceableManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static StartConstructionPlacementCommand()
	{
		Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartConstructionPlacementCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr);
		NativeFieldInfoPtr__signalParams_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr, "<signalParams>k__BackingField");
		NativeFieldInfoPtr__placeableManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr, "<placeableManager>k__BackingField");
		NativeMethodInfoPtr_get_signalParams_Public_get_StartConstructionPlacementSignalParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr, 100669134);
		NativeMethodInfoPtr_set_signalParams_Public_set_Void_StartConstructionPlacementSignalParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr, 100669135);
		NativeMethodInfoPtr_get_placeableManager_Public_get_IPlaceableManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr, 100669136);
		NativeMethodInfoPtr_set_placeableManager_Public_set_Void_IPlaceableManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr, 100669137);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr, 100669138);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr, 100669139);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99803, XrefRangeEnd = 99808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartConstructionPlacementCommand()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartConstructionPlacementCommand>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartConstructionPlacementCommand(IntPtr pointer)
		: base(pointer)
	{
	}
}

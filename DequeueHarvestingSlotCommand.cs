using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.command.impl;

public class DequeueHarvestingSlotCommand : Command
{
	private static readonly IntPtr NativeFieldInfoPtr__signalParams_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_signalParams_Public_get_DequeueHarvestingSlotSignalParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_signalParams_Public_set_Void_DequeueHarvestingSlotSignalParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe DequeueHarvestingSlotSignalParams _signalParams_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__signalParams_k__BackingField);
			return new DequeueHarvestingSlotSignalParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DequeueHarvestingSlotSignalParams>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__signalParams_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dequeueHarvestingSlotSignalParams)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DequeueHarvestingSlotSignalParams>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe DequeueHarvestingSlotSignalParams signalParams
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_signalParams_Public_get_DequeueHarvestingSlotSignalParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DequeueHarvestingSlotSignalParams(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_signalParams_Public_set_Void_DequeueHarvestingSlotSignalParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static DequeueHarvestingSlotCommand()
	{
		Il2CppClassPointerStore<DequeueHarvestingSlotCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DequeueHarvestingSlotCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DequeueHarvestingSlotCommand>.NativeClassPtr);
		NativeFieldInfoPtr__signalParams_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DequeueHarvestingSlotCommand>.NativeClassPtr, "<signalParams>k__BackingField");
		NativeMethodInfoPtr_get_signalParams_Public_get_DequeueHarvestingSlotSignalParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DequeueHarvestingSlotCommand>.NativeClassPtr, 100668758);
		NativeMethodInfoPtr_set_signalParams_Public_set_Void_DequeueHarvestingSlotSignalParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DequeueHarvestingSlotCommand>.NativeClassPtr, 100668759);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DequeueHarvestingSlotCommand>.NativeClassPtr, 100668760);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DequeueHarvestingSlotCommand>.NativeClassPtr, 100668761);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97281, XrefRangeEnd = 97295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe DequeueHarvestingSlotCommand()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DequeueHarvestingSlotCommand>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DequeueHarvestingSlotCommand(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.command.impl;

public class DestroyEntitiesCommand : Command
{
	private static readonly IntPtr NativeFieldInfoPtr__signalParams_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__worldManager_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_signalParams_Public_get_DestroyEntitiesSignalParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_signalParams_Public_set_Void_DestroyEntitiesSignalParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_worldManager_Public_get_IWorldManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_worldManager_Public_set_Void_IWorldManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_destroyEntity_Private_Void_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe DestroyEntitiesSignalParams _signalParams_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__signalParams_k__BackingField);
			return new DestroyEntitiesSignalParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyEntitiesSignalParams>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__signalParams_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destroyEntitiesSignalParams)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DestroyEntitiesSignalParams>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe IWorldManager _worldManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__worldManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IWorldManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__worldManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldManager));
		}
	}

	public unsafe DestroyEntitiesSignalParams signalParams
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_signalParams_Public_get_DestroyEntitiesSignalParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DestroyEntitiesSignalParams(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_signalParams_Public_set_Void_DestroyEntitiesSignalParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IWorldManager worldManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldManager_Public_get_IWorldManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IWorldManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_worldManager_Public_set_Void_IWorldManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static DestroyEntitiesCommand()
	{
		Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DestroyEntitiesCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr);
		NativeFieldInfoPtr__signalParams_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr, "<signalParams>k__BackingField");
		NativeFieldInfoPtr__worldManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr, "<worldManager>k__BackingField");
		NativeMethodInfoPtr_get_signalParams_Public_get_DestroyEntitiesSignalParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr, 100668762);
		NativeMethodInfoPtr_set_signalParams_Public_set_Void_DestroyEntitiesSignalParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr, 100668763);
		NativeMethodInfoPtr_get_worldManager_Public_get_IWorldManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr, 100668764);
		NativeMethodInfoPtr_set_worldManager_Public_set_Void_IWorldManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr, 100668765);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr, 100668766);
		NativeMethodInfoPtr_destroyEntity_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr, 100668767);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr, 100668768);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97295, XrefRangeEnd = 97318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97318, XrefRangeEnd = 97322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void destroyEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_destroyEntity_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DestroyEntitiesCommand()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyEntitiesCommand>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DestroyEntitiesCommand(IntPtr pointer)
		: base(pointer)
	{
	}
}

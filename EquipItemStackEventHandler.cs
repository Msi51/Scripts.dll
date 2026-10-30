using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.injector.api;

public class EquipItemStackEventHandler : NetworkedGameEventHandler<EquipItemStackEventParams, EquipItemStackEventResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_uiManager;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_EquipItemStackEventResult_Int32_EquipItemStackEventParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_attemptEquip_Private_Boolean_InventorySlot_Entity_CharacterInventorySection_Inventory_byref_InventorySlot_0;

	private static readonly IntPtr NativeMethodInfoPtr_dropItemStack_Private_Void_Entity_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_EquipItemStackEventResult_Boolean_0;

	public unsafe IUIManager uiManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IUIManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iUIManager));
		}
	}

	static EquipItemStackEventHandler()
	{
		Il2CppClassPointerStore<EquipItemStackEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EquipItemStackEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipItemStackEventHandler>.NativeClassPtr);
		NativeFieldInfoPtr_uiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemStackEventHandler>.NativeClassPtr, "uiManager");
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemStackEventHandler>.NativeClassPtr, 100670021);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemStackEventHandler>.NativeClassPtr, 100670022);
		NativeMethodInfoPtr_Execute_Public_Virtual_EquipItemStackEventResult_Int32_EquipItemStackEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemStackEventHandler>.NativeClassPtr, 100670023);
		NativeMethodInfoPtr_attemptEquip_Private_Boolean_InventorySlot_Entity_CharacterInventorySection_Inventory_byref_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemStackEventHandler>.NativeClassPtr, 100670024);
		NativeMethodInfoPtr_dropItemStack_Private_Void_Entity_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemStackEventHandler>.NativeClassPtr, 100670025);
		NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_EquipItemStackEventResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemStackEventHandler>.NativeClassPtr, 100670026);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111866, RefRangeEnd = 111867, XrefRangeStart = 111863, XrefRangeEnd = 111866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EquipItemStackEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipItemStackEventHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111867, XrefRangeEnd = 111872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111872, XrefRangeEnd = 111904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override EquipItemStackEventResult Execute(int clientId, EquipItemStackEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&clientId);
		*(EquipItemStackEventParams**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &eventParams;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_EquipItemStackEventResult_Int32_EquipItemStackEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EquipItemStackEventResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111916, RefRangeEnd = 111917, XrefRangeStart = 111904, XrefRangeEnd = 111916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool attemptEquip(InventorySlot targetSlot, Entity entity, CharacterInventorySection section, Inventory inventory, out InventorySlot destinationSlot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSlot);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)section);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_attemptEquip_Private_Boolean_InventorySlot_Entity_CharacterInventorySection_Inventory_byref_InventorySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		destinationSlot = ((num3 == 0) ? null : new InventorySlot(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111917, XrefRangeEnd = 111924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void dropItemStack(Entity entity, InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dropItemStack_Private_Void_Entity_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111924, XrefRangeEnd = 111927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void HandleResult(EquipItemStackEventResult result, bool relayResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&result);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &relayResult;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_EquipItemStackEventResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EquipItemStackEventHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}
